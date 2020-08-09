import { Component, Input, Output, EventEmitter } from "@angular/core";
import { User, UserService } from "src/app/services/user/user.service";
import { BetService, DrawDTO } from "src/app/services/bet/bet.service";

@Component({
  selector: "[balls-area]",
  templateUrl: "./balls-area.component.html",
  styleUrls: ["./balls-area.component.scss", "../../styles/balls.scss"],
})
export class BallsAreaComponent {
  @Input() balls: number[];
  @Input() selectedBalls: number[];
  @Input() drawnBalls: number[];
  @Input() user: User;

  @Output() userChange = new EventEmitter<User>();
  @Output() drawnBallsChange = new EventEmitter<number[]>();
  @Output() selectedBallsChange = new EventEmitter<number[]>();
  @Output() winnings = new EventEmitter<number>();

  constructor(
    private betService: BetService,
    private userService: UserService
  ) {}

  onClickSelectBall(ballNumber: number): void {
    if (this.selectedBalls.includes(ballNumber)) {
      this.selectedBalls = this.selectedBalls.filter(
        (selectedNumber) => ballNumber !== selectedNumber
      );
      return;
    }

    if (this.selectedBalls.length >= 5) return;

    this.selectedBalls.push(ballNumber);
    this.selectedBallsChange.emit(this.selectedBalls);
  }

  onClickChooseRandom(): void {
    this.selectedBalls = [];
    while (this.selectedBalls.length < 5) {
      let randomNumber = Math.floor(Math.random() * 49) + 1;

      if (this.selectedBalls.includes(randomNumber)) continue;

      this.selectedBalls.push(randomNumber);
      this.selectedBallsChange.emit(this.selectedBalls);
    }
  }

  onClickClearSelected(): void {
    this.selectedBalls = [];
    this.selectedBallsChange.emit(this.selectedBalls);
  }

  async onClickBet(): Promise<number[]> {
    if (!this.selectedBalls || this.selectedBalls.length != 5) return;

    const [drawnBalls, winnings]: [
      number[],
      number
    ] = await this.betService.MakeBet(this.selectedBalls, this.user.id);

    this.drawnBalls = drawnBalls;
    this.winnings.emit(winnings);
    this.drawnBallsChange.emit(this.drawnBalls);

    // Update balance
    await this.userService.GetUser().then((data) => {
      this.user = data as User;
    });
    this.userChange.emit(this.user);
  }
}

import { Component } from "@angular/core";
import { User, UserService } from "./services/user/user.service";
import { Bet, BetService } from "./services/bet/bet.service";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./styles/app-styles.scss"],
})
export class AppComponent {
  public balls = new Array(50);
  public bets: Bet[];
  public user: User;
  public selectedBalls: number[];
  public drawnBalls: number[];
  public isDataLoaded = false;
  public winnings: number;

  constructor(
    private betService: BetService,
    private userService: UserService
  ) {
    this.selectedBalls = [];
    this.drawnBalls = [];

    this.userService.GetUser().then((data) => {
      this.user = data as User;
      this.betService.GetAllBetsByUserId(this.user.id).then((data) => {
        this.bets = data;
        this.isDataLoaded = true;
      });
    });
  }
}

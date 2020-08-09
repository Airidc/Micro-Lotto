import { Component, OnInit, Input } from "@angular/core";

@Component({
  selector: "[wtf]",
  templateUrl: "./balls.component.html",
  styleUrls: ["./balls.component.scss", "../../styles/balls.scss"],
})
export class BallsComponent {
  @Input() balls: number[];
  @Input() selectedBalls: number[];

  onClickSelectBall(ballNumber: number): void {
    if (this.selectedBalls.includes(ballNumber)) {
      this.selectedBalls = this.selectedBalls.filter(
        (selectedNumber) => ballNumber !== selectedNumber
      );
      return;
    }

    if (this.selectedBalls.length >= 5) return;

    this.selectedBalls.push(ballNumber);
  }
}

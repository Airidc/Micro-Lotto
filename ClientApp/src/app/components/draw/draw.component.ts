import { Component, Input } from "@angular/core";

@Component({
  selector: "[draw]",
  templateUrl: "./draw.component.html",
  styleUrls: ["./draw.component.scss", "../../styles/balls.scss"],
})
export class DrawComponent {
  constructor() {}

  @Input() drawnBalls: number[];
  @Input() selectedBalls: number[];
}

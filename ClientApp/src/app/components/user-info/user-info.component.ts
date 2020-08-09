import { Component, OnInit, Input } from "@angular/core";
import { User } from "src/app/services/user/user.service";

@Component({
  selector: "[user-info]",
  templateUrl: "./user-info.component.html",
  styleUrls: ["./user-info.component.scss"],
})
export class UserInfoComponent {
  constructor() {}

  @Input() user: User;
}

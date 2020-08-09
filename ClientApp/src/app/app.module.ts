import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";

import { AppComponent } from "./app.component";
import { UserInfoComponent } from "./components/user-info/user-info.component";
import { DrawComponent } from "./components/draw/draw.component";
import { WinningsTableComponent } from "./components/winnings-table/winnings-table.component";
import { BallsAreaComponent } from "./components/balls-area/balls-area.component";

@NgModule({
  declarations: [
    AppComponent,
    UserInfoComponent,
    DrawComponent,
    WinningsTableComponent,
    BallsAreaComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: "ng-cli-universal" }),
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}

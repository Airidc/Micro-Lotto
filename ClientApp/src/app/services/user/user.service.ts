import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

export interface User {
  id: number;
  balance: number;
  username: string;
}

@Injectable({
  providedIn: "root",
})
export class UserService {
  constructor(private http: HttpClient) {}

  GetUser = async (): Promise<User> => {
    let user = await this.http
      .get<User>(`https://localhost:5001/api/user`)
      .toPromise();

    return user;
  };
}

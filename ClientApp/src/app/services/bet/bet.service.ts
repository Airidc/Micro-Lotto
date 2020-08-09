import { Injectable, Inject } from "@angular/core";
import { HttpClient } from "@angular/common/http";

export interface Bet {
  isoTime: string;
  firstNumber: number;
  secondNumber: number;
  thirdNumber: number;
  fourthNumber: number;
  fifthNumber: number;
  userId: number;
}

export interface Draw {
  id: number;
  isoTime: string;
  firstNumber: number;
  secondNumber: number;
  thirdNumber: number;
  fourthNumber: number;
  fifthNumber: number;
}

export interface DrawDTO {
  drawnBalls: Draw;
  winnings: number;
}

@Injectable({
  providedIn: "root",
})
export class BetService {
  constructor(private http: HttpClient) {}

  public GetAllBetsByUserId = async (userId: number): Promise<Bet[]> => {
    let bets = await this.http
      .get<Bet[]>(`https://localhost:5001/api/bet/${userId}`)
      .toPromise();

    return bets;
  };

  MakeBet = async (
    selectedNumbers: number[],
    userId: number
  ): Promise<[number[], number]> => {
    const bet: Bet = {
      isoTime: new Date().toISOString(),
      firstNumber: selectedNumbers[0],
      secondNumber: selectedNumbers[1],
      thirdNumber: selectedNumbers[2],
      fourthNumber: selectedNumbers[3],
      fifthNumber: selectedNumbers[4],
      userId: userId,
    };

    await this.http
      .post("https://localhost:5001/api/bet/save", bet)
      .toPromise();

    let drawDTO: DrawDTO = await this.http
      .post<DrawDTO>(
        `https://localhost:5001/api/draw?userId=${userId}`,
        selectedNumbers
      )
      .toPromise();

    let drawnBalls = [
      drawDTO.drawnBalls.firstNumber,
      drawDTO.drawnBalls.secondNumber,
      drawDTO.drawnBalls.thirdNumber,
      drawDTO.drawnBalls.fourthNumber,
      drawDTO.drawnBalls.fifthNumber,
    ];

    return [drawnBalls, drawDTO.winnings];
  };
}

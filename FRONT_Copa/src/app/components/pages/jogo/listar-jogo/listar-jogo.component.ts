import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { Selecao } from "src/app/models/selecao.model";
import { Jogo } from "src/app/models/jogo.model";
@Component({
  selector: "app-listar-jogo",
  templateUrl: "./listar-jogo.component.html",
  styleUrls: ["./listar-jogo.component.css"],
})
export class ListarJogoComponent implements OnInit {

  selecao!: Selecao[]
  jogos!: Jogo[]

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.http.get<Jogo[]>("https://localhost:5001/api/jogo/listar")
    .subscribe({
      next: (jogos) =>{
        console.log(jogos)
        this.jogos = jogos;
      }
    })

    this.http.get<Selecao[]>("https://localhost:5001/api/selecao/listar")
    .subscribe({
      next: (selecao) =>{
       
      }
    })

  }
}

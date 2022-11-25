import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { Selecao } from "src/app/models/selecao.model";
import { Jogo } from "src/app/models/jogo.model";

@Component({
  selector: "app-cadastrar-jogo",
  templateUrl: "./cadastrar-jogo.component.html",
  styleUrls: ["./cadastrar-jogo.component.css"],
})
export class CadastrarJogoComponent implements OnInit {

  id!: number;
  selecaoA?: Selecao; 
  selecaoB?: Selecao;
  selecaoA_Id!: number;
  selecaoB_Id!: number;
  selecao!: Selecao[];
  
  valorA!: number;
  valorB!: number;


  // id?: number;
  // selecaoA?: Selecao;
  // selecaoB?: Selecao;
  // criadoEm?: string;


  constructor(private http: HttpClient, private router: Router, private route: ActivatedRoute) {}

  ngOnInit(): void {

    this.http.get<Selecao[]>("https://localhost:5001/api/selecao/listar")
    .subscribe({
      next: (selecao) =>{
        console.log(selecao);
        this.selecao = selecao;
      }
    })

  }

  cadastrar(): void {
    
    let jogo: Jogo = {

      selecaoA_id: this.selecaoA_Id,
      selecaoB_id: this.selecaoA_Id,
    };

    this.http.post<Jogo>("https://localhost:5001/api/jogo/cadastrar", jogo)
    .subscribe({
      next: (jogo) => {
        this.router.navigate(["pages/jogo/listar"])
      }
    })

  }

  
}

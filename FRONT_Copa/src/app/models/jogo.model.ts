import { Selecao } from "./selecao.model";

export interface Jogo {
  id?: number,
  selecaoA?: Selecao,
  selecaoB?: Selecao,
  selecaoA_id: number,
  selecaoB_id: number,
  valorA?: number,
  valorB?: number,
  nome?: string,
  criadoEm?: string,
  selecao_id?: number
}

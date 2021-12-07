import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [
    {
      Tema: 'Angular 11',
      Local: 'POA'
    },
    {
      Tema: '.NET 5',
      Local: 'SL'
    },
    {
      Tema: 'Angular & .NET',
      Local: 'BH'
    }
  ]

  constructor() { }

  ngOnInit(): void {
  }

}

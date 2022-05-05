import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'shop-card',
  templateUrl: './shop-card.component.html',
  styleUrls: ['./shop-card.component.scss']
})
export class ShopCardComponent implements OnInit {

  @Input() product: any;

  constructor() { }

  ngOnInit() {
  }

}

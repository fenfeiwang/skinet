import { IProduct } from './../../shared/models/product';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-produt-item',
  templateUrl: './produt-item.component.html',
  styleUrls: ['./produt-item.component.scss']
})
export class ProdutItemComponent implements OnInit {
  @Input() product: IProduct;

  constructor() { }

  ngOnInit(): void {
  }

}

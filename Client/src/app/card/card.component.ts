import {Component, Input, OnInit} from '@angular/core';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.scss']
})
export class CardComponent implements OnInit {

  constructor() { }

  @Input() type: string;
  @Input() title: string;
  @Input() img: string;
  @Input() description: string;
  @Input() tags: string[];

  ngOnInit() {
  }

}
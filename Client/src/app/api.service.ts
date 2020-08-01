import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import ItemInterface from './item-interface';

@Injectable({
  providedIn: 'root'
})

export class ApiService {

  private pageNr = 1;

  constructor(private http: HttpClient) { }

  fetchItems(): Observable<ItemInterface[]> {
    return this.http.get<ItemInterface[]>(`http://localhost:2002/api/items/page/${this.pageNr}/amount/12`);
  }

  paginatePage(): void {
    this.pageNr ++;
  }
}
import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';

import { Hero } from '../models/hero';

@Injectable()
export class HeroSearchService {

  constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) {}

  search(term: string): Observable<Hero[]> {
    return this.http
      .get(this.baseUrl + `api/heroes/?name=${term}`)
      .map(response => response.json() as Hero[]);
  }
}
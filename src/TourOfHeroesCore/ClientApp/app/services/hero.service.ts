import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';

import { Inject } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/empty';

import { Hero } from '../models/hero';

@Injectable()
export class HeroService {
  private heroesUrl = 'api/heroes';  // URL to web api

  constructor(private http: Http, @Inject('BASE_URL') private baseUrl: string) { }

  getHeroes(): Observable<Hero[]> {
    return this.http.get(this.baseUrl + this.heroesUrl)
      .map(response => response.json() as Hero[])
      .catch(this.handleError);
  }

  getHero(id: number): Observable<Hero> {
    const url = `${this.heroesUrl}/${id}`;
    return this.http.get(this.baseUrl + url)
      .map(response => response.json() as Hero);
  }

  private headers = new Headers({ 'Content-Type': 'application/json' });

  update(hero: Hero): Observable<Hero> {
    const url = `${this.heroesUrl}/${hero.id}`;
    return this.http
      .put(this.baseUrl + url, JSON.stringify(hero), { headers: this.headers })
      .map(response => response.json() as Hero);
  }

  create(name: string): Observable<Hero> {
    return this.http
      .post(this.baseUrl + this.heroesUrl, JSON.stringify({ name: name }), { headers: this.headers })
      .map(response => response.json() as Hero);
  }

  delete(id: number): Observable<Hero> {
    const url = `${this.heroesUrl}/${id}`;
    return this.http.delete(this.baseUrl + url, { headers: this.headers })
      .map(response => response.json() as Hero);
  }

  handleError(error: any): Observable<any> {
    console.error('An error occurred', error);
    return Observable.empty();
  }
}

import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';

import { Inject } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/empty';

import { HeroClientService, Hero } from '../services/hero-client.service';

@Injectable()
export class HeroService {
  private heroesUrl = 'api/heroes';  // URL to web api

  constructor(private heroClient: HeroClientService) { }

  getHeroes(): Observable<Hero[]> {
    return this.heroClient.apiHeroesGet("");
  }

  getHero(id: number): Observable<Hero> {
    return this.heroClient.apiHeroesByIdGet(id);
  }

  private headers = new Headers({ 'Content-Type': 'application/json' });

  update(hero: Hero): Observable<Hero> {
    return this.heroClient.apiHeroesByIdPut(hero.id as number, hero);
  }

  create(name: string): Observable<Hero> {
    return this.heroClient.apiHeroesPost(new Hero({ name: name }));
  }

  delete(id: number): Observable<Hero> {
    return this.heroClient.apiHeroesByIdDelete(id);
  }
}

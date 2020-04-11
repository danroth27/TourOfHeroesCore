import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';

import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';

import { HeroClientService, Hero } from '../services/hero-client.service';

@Injectable()
export class HeroSearchService {

  constructor(private heroClient: HeroClientService) {}

  search(term: string): Observable<Hero[]> {
    return this.heroClient.apiHeroesGet(term);
  }
}
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Hero } from '../../services/hero-client.service';
import { HeroService } from '../../services/hero.service';
import { OnInit } from '@angular/core';
   
@Component({
  selector: 'my-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {
  selectedHero: Hero | null;
  heroes: Hero[];

  constructor(
    private heroService: HeroService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.getHeroes();
  }

  onSelect(hero: Hero): void {
    this.selectedHero = hero;
  }

  getHeroes(): void {
    this.heroService.getHeroes().subscribe(heroes => this.heroes = heroes);
  }

  gotoDetail(): void {
    this.router.navigate(['/detail', this.selectedHero!.id as number]);
  }

  add(name: string): void {
    name = name.trim();
    if (!name) { return; }
    this.heroService.create(name)
      .subscribe(hero => {
        this.heroes.push(hero);
        this.selectedHero = null;
      });
  }

  delete(hero: Hero): void {
    this.heroService.delete(hero.id as number)
        .subscribe(() => {
          this.heroes = this.heroes.filter(h => h !== hero);
          if (this.selectedHero === hero) { this.selectedHero = null; }
        });
  }
}

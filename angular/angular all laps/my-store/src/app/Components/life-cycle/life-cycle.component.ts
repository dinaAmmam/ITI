import {
  AfterContentChecked,
  AfterContentInit,
  AfterViewChecked,
  AfterViewInit,
  Component,
  DoCheck,
  OnChanges,
  OnDestroy,
  OnInit,
  SimpleChanges,
} from '@angular/core';

@Component({
  selector: 'app-life-cycle',
  standalone: true,
  imports: [],
  templateUrl: './life-cycle.component.html',
  styleUrl: './life-cycle.component.css',
})
export class LifeCycleComponent
  implements
    OnInit,
    OnChanges,
    DoCheck,
    AfterContentInit,
    AfterContentChecked,
    AfterViewInit,
    AfterViewChecked,
    OnDestroy
{
  firstName: string = 'Eslam';

  constructor() {
  }

  ngOnChanges(): void {
  }

  ngOnInit(): void {
  }

  //
  ngDoCheck(): void {
  }
  //
  ngAfterContentInit(): void {
  }
  //
  ngAfterContentChecked(): void {
  }


  ngAfterViewInit(): void {
  }

  //
  ngAfterViewChecked(): void {
  }

  ngOnDestroy(): void {
  }
}

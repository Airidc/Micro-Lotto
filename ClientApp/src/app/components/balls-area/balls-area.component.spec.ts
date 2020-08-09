import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BallsAreaComponent } from './balls-area.component';

describe('BallsAreaComponent', () => {
  let component: BallsAreaComponent;
  let fixture: ComponentFixture<BallsAreaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BallsAreaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BallsAreaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

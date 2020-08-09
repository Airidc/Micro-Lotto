import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WinningsTableComponent } from './winnings-table.component';

describe('WinningsTableComponent', () => {
  let component: WinningsTableComponent;
  let fixture: ComponentFixture<WinningsTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WinningsTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WinningsTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CsTieredMenuComponent } from './cs-tiered-menu.component';

describe('CsTieredMenuComponent', () => {
  let component: CsTieredMenuComponent;
  let fixture: ComponentFixture<CsTieredMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CsTieredMenuComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CsTieredMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

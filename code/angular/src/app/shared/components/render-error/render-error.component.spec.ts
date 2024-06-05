import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RenderErrorComponent } from './render-error.component';

describe('RenderErrorComponent', () => {
  let component: RenderErrorComponent;
  let fixture: ComponentFixture<RenderErrorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [RenderErrorComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(RenderErrorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RenderErrorComponent } from './render-error.component';
import { TagModule } from 'primeng/tag';


@NgModule({
  declarations: [
    RenderErrorComponent
  ],
  imports: [
    CommonModule,
    TagModule
  ],
  exports: [RenderErrorComponent]
})
export class RenderErrorModule { }

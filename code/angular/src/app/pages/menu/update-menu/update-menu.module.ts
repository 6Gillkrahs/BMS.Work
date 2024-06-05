import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UpdateMenuRoutingModule } from './update-menu-routing.module';
import { UpdateMenuComponent } from './update-menu.component';


@NgModule({
  declarations: [
    UpdateMenuComponent
  ],
  imports: [
    CommonModule,
    UpdateMenuRoutingModule
  ]
})
export class UpdateMenuModule { }

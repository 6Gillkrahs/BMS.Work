import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AddMenuRoutingModule } from './add-menu-routing.module';
import { AddMenuComponent } from './add-menu.component';


@NgModule({
  declarations: [
    AddMenuComponent
  ],
  imports: [
    CommonModule,
    AddMenuRoutingModule
  ]
})
export class AddMenuModule { }

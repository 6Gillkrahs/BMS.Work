import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CsTieredMenuRoutingModule } from './cs-tiered-menu-routing.module';
import { CsTieredMenuComponent } from './cs-tiered-menu.component';


@NgModule({
  declarations: [
    CsTieredMenuComponent
  ],
  imports: [
    CommonModule,
    CsTieredMenuRoutingModule
  ]
})
export class CsTieredMenuModule { }

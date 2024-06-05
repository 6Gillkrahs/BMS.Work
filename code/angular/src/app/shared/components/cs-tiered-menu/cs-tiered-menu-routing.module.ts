import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CsTieredMenuComponent } from './cs-tiered-menu.component';

const routes: Routes = [{ path: '', component: CsTieredMenuComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CsTieredMenuRoutingModule { }

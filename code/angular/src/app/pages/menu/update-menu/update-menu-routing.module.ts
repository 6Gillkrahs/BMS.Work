import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UpdateMenuComponent } from './update-menu.component';

const routes: Routes = [{ path: '', component: UpdateMenuComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UpdateMenuRoutingModule { }

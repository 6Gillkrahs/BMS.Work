import { UpdateMenuComponent } from './update-menu/update-menu.component';
import { AddMenuComponent } from './add-menu/add-menu.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MenuRoutingModule } from './menu-routing.module';
import { MenuComponent } from './menu.component';
import { TreeTableModule } from 'primeng/treetable';
import { ButtonModule } from 'primeng/button';
import { DialogModule } from 'primeng/dialog';
import { DividerModule } from 'primeng/divider';
import { InputTextModule } from 'primeng/inputtext';
import { RippleModule } from 'primeng/ripple';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AutoCompleteModule } from 'primeng/autocomplete';
import { InputNumberModule } from 'primeng/inputnumber';
import { CheckboxModule } from 'primeng/checkbox';
import { TreeSelectModule } from 'primeng/treeselect';
import { SelectButtonModule } from 'primeng/selectbutton';
import { DropdownModule } from 'primeng/dropdown';
import { ConfirmationService, MessageService } from 'primeng/api';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { ToastModule } from 'primeng/toast';
import { MenuService } from '@proxy/menus';
import { SharedModule } from 'src/app/shared/shared.module';
import { RenderErrorComponent } from '../../shared/components/render-error/render-error.component';

@NgModule({
  declarations: [
    MenuComponent,
    AddMenuComponent,
    UpdateMenuComponent,
    // RenderErrorComponent
  ],
  imports: [
    CommonModule,
    MenuRoutingModule,
    TreeTableModule,
    ButtonModule,
    DialogModule,
    DividerModule,
    InputTextModule,
    RippleModule,
    FormsModule,
    ReactiveFormsModule,
    AutoCompleteModule,
    InputNumberModule,
    CheckboxModule,
    TreeSelectModule,
    SelectButtonModule,
    DropdownModule,
    ConfirmDialogModule,
    ToastModule,
    SharedModule
  ],
  providers: [MenuService,MessageService, ConfirmationService]
})
export class MenuModule { }

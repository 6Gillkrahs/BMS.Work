import { ReplaceableComponentsService } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { ConfirmationService, MessageService } from 'primeng/api';
import { LayoutService } from './layout/service/app.layout.service';
import { AppLayoutComponent } from './layout/app.layout.component';
import { eThemeBasicComponents } from '@abp/ng.theme.basic';
import { NotificationService } from './shared/services/notification.service';

@Component({
  selector: 'app-root',
  template: `
    <abp-loader-bar></abp-loader-bar>
    <abp-dynamic-layout></abp-dynamic-layout>
    <abp-internet-status></abp-internet-status>
  `,
  providers: [NotificationService, ConfirmationService,MessageService]
})
export class AppComponent implements OnInit{
  ngOnInit(): void {
    
  }

  constructor(
    private messageService: MessageService,
    private replaceableComponents: ReplaceableComponentsService , 
     private layoutService: LayoutService
  ) {
    this.replaceableComponents.add({
      component: AppLayoutComponent,
      key: eThemeBasicComponents.ApplicationLayout,
    });  
  }
}

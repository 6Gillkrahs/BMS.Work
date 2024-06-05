import { MenuService } from './proxy/menus/menu.service';
import { GetListMenuDto } from './proxy/menus/dtos/models';
import { MySettingsComponent } from './my-settings/my-settings.component';
import { AuthService, ConfigStateService, ReplaceableComponentsService, RoutesService } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { ConfirmationService, MenuItem, MessageService, PrimeNGConfig } from 'primeng/api';
import { LayoutService } from './layout/service/app.layout.service';
import { AppLayoutComponent } from './layout/app.layout.component';
import { eThemeBasicComponents } from '@abp/ng.theme.basic';
import { NotificationService } from './shared/services/notification.service';
import { SettingTabsService } from '@abp/ng.setting-management/config';


@Component({
  selector: 'app-root',
  template: `
    <abp-loader-bar></abp-loader-bar>
    <abp-dynamic-layout></abp-dynamic-layout>
    <abp-internet-status></abp-internet-status>
  `,
  providers: [NotificationService, ConfirmationService, MessageService]
})
export class AppComponent implements OnInit {

  items: MenuItem[] = [];
  menuAbp: boolean = false;
  blockScreen: boolean = false;
  currentUser: any;




  menuItem = {
    totalCount: 1,
    items: [
      {
        routerLink: null,
        url: null,
        label: "Bàn làm việc",
        order: 2,
        iconClass: "",
        requiredPolicy: null,
        layout: null,
        parentId: null,
        isGroup: true,
        clientId: "Work_App",
        id: "table1"
      },
      {
        routerLink: "/identity/roles",
        url: null,
        label: "Tạo mới công việc",
        order: 1,
        iconClass: "pi pi-users",
        requiredPolicy: null,
        layout: null,
        parentId: "table1",
        isGroup: false,
        clientId: "Work_App",
        id: "work1"
      }
    ]
  }

  ngOnInit(): void {
    this.config.getOne$('currentUser').subscribe((currentUser) => {
      this.currentUser = currentUser;
      console.log(currentUser)
    });
    this.primengConfig.ripple = true;
    this.getNavMenu()
  }

  constructor(
    private messageService: MessageService,
    private replaceableComponents: ReplaceableComponentsService,
    private layoutService: LayoutService,
    private primengConfig: PrimeNGConfig,
    private authService: AuthService,
    public config: ConfigStateService,
    private routes: RoutesService,
    private settingTabs: SettingTabsService,
    private menuService: MenuService
  ) {
    this.replaceableComponents.add({
      component: AppLayoutComponent,
      key: eThemeBasicComponents.ApplicationLayout,
    });

    settingTabs.add([
      {
        name: 'MySettings',
        order: 1,
        requiredPolicy: 'policy key here',
        component: MySettingsComponent,
      },
    ])
  }

  get hasLoggedIn(): boolean {
    return this.authService.isAuthenticated;
  }

  getNavMenu() {
    this.menuService.getList({
      clientId: 'Work_App',
    })
      .subscribe({
        next: (res) => {
          const root = this.convertListToTree(res.items);
          this.routes.navMenuService$.next(root.items);
          // console.log(this.routes.navMenuService$.value)
        },
        error: (err) => {

        }
      })
  }

  completeNode(id: string, node: any, list: any[]) {
    node.items = list.filter(x => x['parentId'] == id).sort(x => x.order).map(x => {
      if (x.isGroup) {
        let childNode = {
          label: x.label,
          icon: x.iconClass,
          items: []
        };
        this.completeNode(x.id, childNode, list);
        return childNode;
      } else {
        if (x.url) {
          return {
            label: x.label,
            icon: x.iconClass,
            url: x.url
          };
        } else {
          return {
            label: x.label,
            icon: x.iconClass,
            routerLink: [x.routerLink]
          };
        }
      }
    });
  }

  convertListToTree<T>(list: T[]) {
    let rootNode = { items: [] };
    this.completeNode(null, rootNode, list);
    return rootNode;
  }

  login() {
    this.authService.navigateToLogin();
  }
}

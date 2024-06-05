import { MenuService } from '@proxy/menus';
import { OnInit } from '@angular/core';
import { Component } from '@angular/core';
import { LayoutService } from './service/app.layout.service';
import { MenuItem } from 'primeng/api';

@Component({
    selector: 'app-menu',
    templateUrl: './app.menu.component.html'
})
export class AppMenuComponent implements OnInit {

    model: any[] = [];

    menus: MenuItem[] = [];

    menuModel: any[] = [];



    constructor(
        public layoutService: LayoutService,
        public menuService: MenuService
    ) { }

    ngOnInit() {
        this.getMenus();
        this.model = [
            {
                label: 'Home',
                items: [
                    { label: 'Dashboard', icon: 'pi pi-fw pi-home', routerLink: ['/menu-management'] }
                ]
            },
        ];
    }

    getMenus() {
        this.menuService.getList({
            clientId: "Work_App"
        }).subscribe({
            next: (res) => {
                let root = this.convertListToTree(res.items);
                this.menus = root.items;
                console.log(this.menus)
            }
        })
    }

    completeNode(node: any, list: any[]) {
        node.items = list.filter(x => x['parentId'] == node.label.id).sort(x => x.order).map(x => {
            let childNode = {
                label: x,
                items: []
            };
            this.completeNode(childNode, list);
            return childNode;
        });
    }

    convertListToTree<T>(list: T[]) {
        let rootNode = { label: { id: null }, items: [] };
        this.completeNode(rootNode, list);
        return rootNode;
    }

    


}

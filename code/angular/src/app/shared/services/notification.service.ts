import { Injectable } from '@angular/core';
import { MessageService } from 'primeng/api';

@Injectable()
export class NotificationService {
    constructor(private messageService: MessageService) { }

    showSuccess(message: string): void {
        this.messageService.add({ severity: 'success', summary: 'success', detail: message });
    }
    showError(message: string): void {
        this.messageService.add({ severity: 'error', summary: 'error', detail: message });
    }
    showInfo(message: string): void {
        this.messageService.add({ severity: 'info', summary: 'info', detail: message });
    }
    showWarn(message: string): void {
        this.messageService.add({ severity: 'warn', summary: 'warn', detail: message });
    }
}
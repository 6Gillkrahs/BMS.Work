import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Work',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44318/',
    redirectUri: baseUrl,
    clientId: 'Work_App',
    responseType: 'code',
    scope: 'offline_access Work',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44314',
      rootNamespace: 'BMS.Work',
    },
  },
} as Environment;

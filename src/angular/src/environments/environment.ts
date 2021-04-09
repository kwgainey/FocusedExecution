import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'FocusedExecution',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44308',
    redirectUri: baseUrl,
    clientId: 'FocusedExecution_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone FocusedExecution',
  },
  apis: {
    default: {
      url: 'https://localhost:44376',
      rootNamespace: 'FocusedExecution',
    },
  },
} as Environment;

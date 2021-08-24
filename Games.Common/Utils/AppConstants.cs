namespace Games.Common.Utils
{
    public static class AppConstants
    {
        #region Constants
        public const string ConnectionStringKey = "ConnStr";
        public const string UpdateCustomerAPITraceKey = "B2B-API-Trace-UpdateCustomer";
        public const string SendGridMailSettingsApiKey = "SendGridMailSettings:ApiKey";
        public const string SendGridMailSettingsFrom = "SendGridMailSettings:From";
        public const string SendGridMailSettingsSender = "SendGridMailSettings:Sender";
        public const string HttpTriggerSqlDatabaseSchemaJson = @"{
                    '$schema': 'http://json-schema.org/draft-04/schema#',
                    'type': 'object',
                    'properties': {
                        'name': {
                            'type': 'string'
                        },
                        'type': {
                            'type': 'string'
                        },
                        'address': {
                            'type': 'object',
                            'properties': {
                                'street': {
                                    'type': 'string'
                                },
                                'province': {
                                    'type': 'string'
                                },
                                'city': {
                                    'type': 'string'
                                },
                                'postuuyualcode': {
                                    'type': 'string'
                                }
                            },
                            'required': [
                                'street',
                                'province',
                                'city',
                                'postuuyualcode'
                            ]
                        }
                    },
                    'required': [
                        'name',
                        'type',
                        'address'
                    ]
                }";

        public const string UpdateCustomerSchemaJson = @"{
            '$schema': 'http://json-schema.org/draft-04/schema#',
            'type': 'object',
            'properties': {
                'createcustomerd365response': {
                    'type': 'object',
                    'properties': {
                        'responseheader': {
                            'type': 'object',
                            'properties': {
                                'system': {
                                    'type': 'string'
                                },
                                'transactionid': {
                                    'type': 'string'
                                },
                                'transactiontype': {
                                    'type': 'string'
                                },
                                'messagedatetime': {
                                    'type': 'string'
                                },
                                'operation': {
                                    'type': 'string'
                                },
                                'description': {
                                    'type': 'string'
                                }
                            },
                            'required': [
                                'system',
                                'transactionid',
                                'transactiontype',
                                'messagedatetime',
                                'operation',
                                'description'
                            ]
                        },
                        'responsedata': {
                            'type': 'object',
                            'properties': {
                                'createcustomerresponse': {
                                    'type': 'object',
                                    'properties': {
                                        'status': {
                                            'type': 'string'
                                        },
                                        'message': {
                                            'type': 'string'
                                        },
                                        'uniquecustomerid': {
                                            'type': 'string'
                                        }
                                    },
                                    'required': [
                                        'status',
                                        'message',
                                        'uniquecustomerid'
                                    ]
                                }
                            },
                            'required': [
                                'createcustomerresponse'
                            ]
                        }
                    },
                    'required': [
                        'responseheader',
                        'responsedata'
                    ]
                }
            },
            'required': [
                'createcustomerd365response'
            ]
        }";

        public const string CreateCustomerAckSchemaJson = @"{
            '$schema': 'http://json-schema.org/draft-04/schema#',
            'type': 'object',
            'properties': {
                'createcustomeracknowledgement': {
                    'type': 'object',
                    'properties': {
                        'responseheader': {
                            'type': 'object',
                            'properties': {
                                'system': {
                                    'type': 'string'
                                },
                                'transactionid': {
                                    'type': 'string'
                                },
                                'transactiontype': {
                                    'type': 'string'
                                },
                                'messagedatetime': {
                                    'type': 'string'
                                },
                                'operation': {
                                    'type': 'string'
                                },
                                'description': {
                                    'type': 'string'
                                }
                            },
                            'required': [
                                'system',
                                'transactionid',
                                'transactiontype',
                                'messagedatetime',
                                'operation',
                                'description'
                            ]
            },
                        'responsedata': {
                            'type': 'object',
                            'properties': {
                                'status': {
                                    'type': 'string'
                                },
                                'message': {
                                    'type': 'string'
                                }
                            },
                            'required': [
                                'status',
                                'message'
                            ]
                        }
                    },
                    'required': [
                        'responseheader',
                        'responsedata'
                    ]
                }
            },
            'required': [
                'createcustomeracknowledgement'
            ]
        }";

        public const string SESSION_COOKIE_NAME = ".OCS.Session";
        public const string REMEMBER_ME_EMAIL = "OCSB2BRememberMeEmail";
        public const string USER_LANGUAGE_COOKIE_NAME = ".OCS.UserLanguage";
        #endregion

    }
}

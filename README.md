# Polymorphic API

POST https://localhost:port/api/events

### Create Event
```
{
    "eventType": "CreateEvent",
    "name": "This is a create event",
    "quantity": 100
}
```

### Cancel Event

```
{
    "eventType": "CancelEvent",
    "id": 100,
    "reason": "Didn't like it."
}
```

## Swagger Json
```
{
  "openapi": "3.0.1",
  "info": {
    "title": "PolymorphicAPI",
    "version": "1.0"
  },
  "paths": {
    "/api/Events": {
      "post": {
        "tags": [
          "Events"
        ],
        "requestBody": {
          "content": {
            "application/json-patch+json": {
              "schema": {
                "oneOf": [
                  {
                    "$ref": "#/components/schemas/EventCommand"
                  },
                  {
                    "$ref": "#/components/schemas/CreateEventCommand"
                  },
                  {
                    "$ref": "#/components/schemas/CancelEventCommand"
                  }
                ],
                "nullable": true
              }
            },
            "application/json": {
              "schema": {
                "oneOf": [
                  {
                    "$ref": "#/components/schemas/EventCommand"
                  },
                  {
                    "$ref": "#/components/schemas/CreateEventCommand"
                  },
                  {
                    "$ref": "#/components/schemas/CancelEventCommand"
                  }
                ],
                "nullable": true
              }
            },
            "text/json": {
              "schema": {
                "oneOf": [
                  {
                    "$ref": "#/components/schemas/EventCommand"
                  },
                  {
                    "$ref": "#/components/schemas/CreateEventCommand"
                  },
                  {
                    "$ref": "#/components/schemas/CancelEventCommand"
                  }
                ],
                "nullable": true
              }
            },
            "application/*+json": {
              "schema": {
                "oneOf": [
                  {
                    "$ref": "#/components/schemas/EventCommand"
                  },
                  {
                    "$ref": "#/components/schemas/CreateEventCommand"
                  },
                  {
                    "$ref": "#/components/schemas/CancelEventCommand"
                  }
                ],
                "nullable": true
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    }
  },
  "components": {
    "schemas": {
      "EventCommand": {
        "type": "object",
        "properties": {
          "eventType": {
            "type": "string",
            "nullable": true
          }
        },
        "additionalProperties": false
      },
      "CreateEventCommand": {
        "type": "object",
        "properties": {
          "eventType": {
            "type": "string",
            "nullable": true
          },
          "name": {
            "type": "string",
            "nullable": true
          },
          "quantity": {
            "type": "integer",
            "format": "int32"
          }
        },
        "additionalProperties": false
      },
      "CancelEventCommand": {
        "type": "object",
        "properties": {
          "eventType": {
            "type": "string",
            "nullable": true
          },
          "id": {
            "type": "integer",
            "format": "int32"
          },
          "reason": {
            "type": "string",
            "nullable": true
          }
        },
        "additionalProperties": false
      }
    }
  }
}
```

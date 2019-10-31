"use strict";

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/futureagrohub", {
        accessTokenFactory: () => "testing"
    })
    .build();

#!/bin/sh

SCRIPT_PATH=$(cd $(dirname $0) && pwd)

APP_PATH="$SCRIPT_PATH/../Build/app"

ios-deploy --debug --bundle $APP_PATH/SandBox.app
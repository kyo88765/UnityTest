#!/bin/sh

UNITY_PATH="/Applications/Unity/Unity.app/Contents/MacOS"

PROJECT_PATH="../"
EXECUTE_METHOD="BuildClass.Build"

$UNITY_PATH/Unity -batchmode -quit \
    -projectPath $PROJECT_PATH
    -executeMethod $EXECUTE_METHOD 
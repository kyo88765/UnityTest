#!/bin/sh

SCRIPT_PATH=$(cd $(dirname $0) && pwd)

PROJECT_PATH="$SCRIPT_PATH/../Build/Unity-iPhone.xcodeproj"
SCHEME="Unity-iPhone"
DESTINATION="platform=iOS,id=b32e2c78da6ed5a365e5dee5a458735d4819765f"

xcodebuild \
    DEVELOPMENT_TEAM="5DAMAH47RE"
    -project $PROJECT_PATH \
    -scheme $SCHEME \
    -destination $DESTINATION \
    -configuration Debug \
    build
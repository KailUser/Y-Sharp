cmake_minimum_required(VERSION 3.0)
project(Y-SHARP)

add_library(YSHARP SHARED YSHARP.cs)

add_executable(Example Example.cs)
target_link_libraries(Example YSHARP)

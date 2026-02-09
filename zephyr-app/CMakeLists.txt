# CMakeLists.txt for Nordic NUS Zephyr App

# Set minimum CMake version
cmake_minimum_required(VERSION 3.13)

# Set project name and version
project(nus_app VERSION 0.1 LANGUAGES C)

# Include Zephyr as a module
find_package(Zephyr REQUIRED HINTS $ENV{ZEPHYR_BASE})
include(${ZEPHYR_BASE}/cmake/app/boilerplate.cmake)

# Source files in the application
set(SOURCES
    src/main.c
)

# Add executable target
zephyr_app_sources(${SOURCES})

# Optionally, add other required configurations such as libraries or dependencies
# target_link_libraries(my_target additional_library)

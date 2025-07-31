# Angry Birds Console Prototype

A comprehensive .NET 9 console application demonstrating structural design patterns through an Angry Birds game simulation. This project showcases the **Strategy Pattern** and **Composite Pattern** in action with an engaging gameplay experience.

## 🐦 Overview

The Angry Birds Console Prototype simulates the classic mobile game experience through text-based gameplay. Players command different bird types with unique special abilities to destroy strategically built pig fortresses. The system demonstrates how structural design patterns can create flexible, maintainable game architectures.

## 🎯 Features

- **Multiple Bird Types**: Four distinct birds with unique special abilities and powers
- **Strategy Pattern Implementation**: Interchangeable bird behaviors with runtime flexibility
- **Composite Pattern Structure**: Hierarchical fortress construction with nested components
- **Dynamic Damage System**: Health-based destruction with cascading effects
- **Interactive Gameplay**: Sequential bird launches with real-time fortress status
- **Comprehensive Display**: Detailed console output for all game phases and bird abilities

## 🏗️ Architecture

### Design Patterns Used

1. **Strategy Pattern**
   - `IBirdBehavior` (Strategy Interface)
   - `ExplosiveBehavior`, `PushBehavior`, `SpeedBoostBehavior`, `SplitBehavior` (Concrete Strategies)
   - `Bird` (Context that uses behaviors)

2. **Composite Pattern**
   - `GameElement` (Component base class)
   - `Structure` (Composite that contains other elements)
   - Individual blocks and pigs (Leaf components)

## 🐦 Bird Arsenal

### 🔴 Red Bird
- **Power**: 10 damage
- **Special Ability**: Push Behavior
- **Strategy**: Direct impact with enhanced pushing force
- **Best Against**: Light structures and wooden barriers

### ⚫ Black Bird  
- **Power**: 10 damage
- **Special Ability**: Explosive Behavior
- **Strategy**: Area-of-effect destruction on impact
- **Best Against**: Dense structures and multiple targets

### 🟡 Yellow Bird
- **Power**: 10 damage  
- **Special Ability**: Speed Boost Behavior
- **Strategy**: Accelerated impact for increased penetration
- **Best Against**: Strong barriers requiring extra force

### � Blue Bird
- **Power**: 10 damage
- **Special Ability**: Split Behavior  
- **Strategy**: Multiplies into multiple projectiles mid-flight
- **Best Against**: Wide structures and multiple weak points

## 🏰 Fortress Components

### Building Materials
- **Glass Block**: 15 HP - Fragile, shatters easily under pressure
- **Wood Block**: 25 HP - Medium durability, balanced resistance
- **Stone Block**: High HP - Maximum durability, requires strategic targeting
- **Pig**: Variable HP - Primary targets hidden within structures

### Composite Structure System
The fortress utilizes a hierarchical design:
```
Pig Fortress
├── Base Layer (Stone foundation)
├── Middle Layer (Glass walls + Pig targets)
└── Top Layer (Wood reinforcements)
```

## 🎮 Gameplay Flow

1. **Bird Selection Phase**: Display all available birds with detailed ability descriptions
2. **Fortress Generation**: Automatically construct a multi-layered pig fortress
3. **Launch Sequence**: Each bird launches individually with special power activation
4. **Impact Assessment**: Calculate damage, update structure health, and display results
5. **Victory Condition**: Game ends when fortress is destroyed or all birds are exhausted
6. **Real-time Feedback**: Continuous fortress status updates after each attack

## 🎨 Design Benefits

- **Behavioral Flexibility**: Easy addition of new bird abilities without modifying existing classes
- **Structural Modularity**: Fortress components can be reorganized and extended seamlessly  
- **Code Reusability**: Common game element behaviors defined in base abstractions
- **Polymorphic Treatment**: Uniform handling of different birds and structure components
- **Maintainable Architecture**: Clear separation between game logic and behavior implementations

## 🔮 Future Enhancements

- Add trajectory calculation and physics simulation
- Implement multiple fortress layouts and difficulty levels
- Create bird upgrade system with enhanced abilities
- Add scoring system based on efficiency and remaining birds
- Implement multiplayer modes with fortress design challenges
- Create save/load functionality for custom fortress designs
- Add visual ASCII art representations for enhanced gameplay

## 📚 Learning Objectives

This project demonstrates:
- **Strategy Pattern**: Runtime behavior selection and interchangeable algorithms
- **Composite Pattern**: Tree-like object structures with uniform component treatment
- **Polymorphism**: Dynamic method dispatch for birds and game elements
- **Abstraction**: Clean interfaces separating implementation from behavior
- **SOLID Principles**: Especially Open/Closed and Single Responsibility principles

## 📄 License

This project is created for educational purposes to demonstrate structural design patterns in C# game development.
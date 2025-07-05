# Reclaim

**Reclaim** is a tribal language revitalization game designed to reconnect Indigenous youth with their ancestral language, and culture. Blending traditional oral knowledge with modern tools, Reclaim creates an interactive space to learn through voice, storytelling, and play.

## 🌱 Purpose

This project was created as a way to:

- Preserve and pass on endangered tribal languages
- Give youth an engaging way to learn through games
- Build a platform where community voices—especially elders—can be heard
- Foster pride, identity, and connection through culture

## 🎮 Vision

Reclaim isn’t just a game—it's a cultural tool. Language is more than vocabulary; it carries worldview, history, and belonging. Our goal is to help players:

- Learn their language through voice-based interactions
- Explore traditional stories and knowledge
- Participate in a living, evolving archive of cultural material
- Contribute to language preservation with tools for families and communities

## 📦 Features (Planned)

- 🔊 Elder voice clips for vocabulary and pronunciation
- 🧠 Memory and quiz games to reinforce language learning

## ⚒️ Tech Stack (WIP)

- **Engine**: Unity (with UI Toolkit)
- **Platform**: Desktop and Mobile (Android/iOS)
- **Data**: JSON-based content system with localization
- **Project Folder Struture**:
```
Assets/
├── _Project/ # Core game-specific code and assets
│ ├── Scripts/
│ │ ├── Core/ # Game loop, managers, data handling
│ │ ├── UI/ # Custom UI logic (binders, controllers)
│ │ ├── Language/ # Language-specific systems (parsing, progress)
│ │ └── MiniGames/ # Each game mode as a separate component
│ ├── UI/
│ │ ├── UXML/ # UI Toolkit layouts (.uxml)
│ │ ├── USS/ # UI styles (.uss)
│ │ ├── Controls/ # Reusable UI widgets/components
│ │ └── Screens/ # Menus, lesson UI, quiz screens, etc.
│ ├── Audio/
│ │ ├── Elders/ # Voice clips.
│ │ └── SFX/ # Button clicks, transitions, etc.
│ ├── Art/
│ │ ├── Icons/ # UI icons and symbols
│ │ └── Illustrations/ # Culturally relevant artwork
│ ├── Data/
│ │ ├── Localization/ #
│ │ ├── Lessons/ # ScriptableObjects or JSON for vocab/grammar units
│ │ └── Metadata/ # Language meta info, progress tracking
│ └── Resources/ # For Resources.Load()
│
├── ThirdParty/ # Any third-party packages or tools
├── Editor/ # Custom editor tooling or utilities
├── StreamingAssets/ # Audio/text files that need direct access
└── Scenes/ # Game scenes (Menu, Lessons, MiniGames)
```
## ✨ Status

Currently in early pre-production — prototyping UI, shaping core gameplay loops, and building content pipelines. The goal is to keep things modular, extensible, and respectful of community input.

## 🧭 Guiding Values

- **Respect**: Language and stories are sacred. Everything is done in partnership with culture-bearers and with permission.
- **Accessibility**: Designed for learners of all ages and tech skill levels.

## 🙌 Contributors

This project is being developed by [Silas H.](@Shafeli), a Native software engineer, game developer, and passionate advocate for language and cultural preservation.

If you're a speaker, artist, developer, or just want to help—reach out.

## 🪶 Acknowledgments

To the elders, speakers, and teachers who have carried our words through time—we see you. This project is for you, and because of you.

---

> **"When we reclaim our language, we reclaim ourselves."**

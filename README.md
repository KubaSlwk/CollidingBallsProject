# BallSim 🎯

**BallSim** to prosty symulator zderzeń kul w przestrzeni 2D, stworzony w technologii Windows Forms przy użyciu języka C#.

Projekt umożliwia wizualizację ruchu piłek wewnątrz ograniczonego pola oraz ich wzajemnych zderzeń, z uwzględnieniem masy, prędkości i kierunku.

---

## 🧩 Funkcje

- 🔁 Start/Stop symulacji
- ➕ Dodawanie nowych piłek w losowych pozycjach
- 🎚️ Dynamiczna zmiana promienia i masy wybranej piłki za pomocą suwaka
- ⬅️➡️ Przełączanie się między piłkami
- ⏬ Zmniejszanie i ⏫ zwiększanie prędkości aktualnie wybranej piłki
- 🧠 Obsługa kolizji: sprężyste zderzenia z odbiciem od ścian i innych piłek

---

## ⚙️ Technologie

- C#
- .NET Framework / WinForms
- GDI+ (System.Drawing)

---

## Struktura Folderów

BallSim/
├── Form1.cs               # Główna forma aplikacji
├── Ball.cs                # Klasa reprezentująca piłkę
├── Vec2D.cs               # Prosty wektor 2D
├── BBox.cs                # Obszar symulacji
├── SimulationBox.cs       # Klasa zarządzająca przebiegiem symulacji
├── Naive2Algo.cs          # Algorytm zderzeń
├── README.md              # Ten plik 🙂
└── BallSim.csproj

---

## 🚀 Uruchamianie

1. Sklonuj repozytorium:

   ```bash
   git clone https://github.com/kubaslwk/CollidingBallsProject.git

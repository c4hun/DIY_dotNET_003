# DIY_dotNET_003 - Application d’authentification avec TDD (.NET MVC) - AuthApp

---

## 🧠 Objectif

Créer une application d’authentification (login) en .NET MVC, en suivant une approche TDD (Test Driven Development).  
Le projet peut être utilisé comme un composant indépendant ou intégré dans d’autres projets.

---

## 🧭 Structure du projet
```markdown
DIY_dotNET_003/
│
├── AuthApp/ # Projet principal (.NET MVC)
│ ├── Controllers/
│ ├── Models/
│ ├── Services/
│ ├── Views/
│ └── AuthApp.csproj
│
├── AuthApp.Tests/ # Projet de tests unitaires (xUnit)
│ ├── LoginTests.cs
│ └── AuthApp.Tests.csproj
│
└── DIY_dotNET_003.sln # Solution Visual Studio
```

---

## 🧱 Étapes clés du développement

| Étape | Action                                  | But                          |
|-------|----------------------------------------|------------------------------|
| 0     | Créer solution DIY_dotNET_003           | Nouvelle base                |
| 1     | Écrire un premier test de login          | Entrer dans TDD              |
| 2     | Implémenter `AuthService`                | Passer le test               |
| 3     | Ajouter l’UI MVC                         | Application interactive      |
| 4     | Réutiliser dans projets DIY_dotNET_001/002 | Intégration                  |
| 5     | (Optionnel) Créer une API                | Découpler complètement       |

---

## 🔍 Composants principaux (étapes 2 à 3.3)

### 🇫🇷 Description en français

- **`AuthService`** : Service métier qui valide les identifiants utilisateur (`Login(username, password)`).
- **`IUserRepository`** : Interface abstraite pour accéder aux utilisateurs et valider les credentials.
- **`InMemoryUserRepository`** : Implémentation simple en mémoire pour simuler une base de données.
- **Tests unitaires** : Tests écrits en TDD pour s’assurer que `AuthService` fonctionne correctement.
- **`LoginController`** : Contrôleur MVC qui gère l’affichage du formulaire de connexion et la validation via `AuthService`.
- **Vues Razor (`Index.cshtml` & `Welcome.cshtml`)** : Interface utilisateur permettant de saisir les identifiants et d’afficher un message de bienvenue ou une erreur.

### 🇬🇧 Description in English

- **`AuthService`**: Business service that validates user credentials (`Login(username, password)`).
- **`IUserRepository`**: Abstract interface to access users and validate credentials.
- **`InMemoryUserRepository`**: Simple in-memory implementation to simulate a database.
- **Unit Tests**: TDD-written tests ensuring `AuthService` behaves correctly.
- **`LoginController`**: MVC controller that handles the login form display and validation via `AuthService`.
- **Razor Views (`Index.cshtml` & `Welcome.cshtml`)**: User interface to input credentials and show welcome or error messages.

---

## 📡 Fonctionnement global (flux)

1. L’utilisateur accède à la page de login (`GET /Login/Index`).
2. Le contrôleur affiche le formulaire.
3. L’utilisateur saisit son `username` et `password`, puis soumet (`POST /Login/Index`).
4. Le contrôleur appelle `AuthService.Login`.
5. `AuthService` demande à `IUserRepository` de valider les identifiants.
6. Si correct, redirection vers la page `Welcome`.
7. Sinon, affichage d’un message d’erreur dans la vue.

---

## 📦 Conclusion

Ce projet est une base modulaire et testée pour un système d’authentification en .NET MVC, conçue selon les bonnes pratiques TDD.  
Il peut évoluer vers une API REST, ou s’intégrer dans des projets plus larges.

---

Si tu veux, je peux aussi te fournir les instructions détaillées pour continuer avec l’injection de dépendance ou la création d’une API REST.

---

# Licence

Ce projet est sous licence MIT - libre d'utilisation.

---

*Merci de contribuer ou poser tes questions !*  

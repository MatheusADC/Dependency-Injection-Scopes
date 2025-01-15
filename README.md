# <img src="https://github.com/user-attachments/assets/caabfdf0-0f9e-44a3-8200-c6579fe87887" alt="speech bubble" width="28"> Description
Study on Dependency Injection Scopes.

# 🎯Scopes

### 🔄 1. Singleton Scope
- Creates one single instance for the entire application lifecycle;
- All consumers use the same instance;
- Suitable for stateful services or heavy resources like databases, caches, etc.

### 🌱 2. Transient Scope
- Creates a new instance every time the dependency is requested;
- Each consumer gets a different instance;
- Ideal for stateless or short-lived services.

### 🌐 3. Scoped Scope
- Creates a new instance per request (e.g., one instance per HTTP request);
- Same instance is shared across the request but discarded after it ends;
- Useful for user-specific services in web applications.

# 🎛️Swagger
![image](https://github.com/user-attachments/assets/a261f07e-2535-4e3a-bf63-65b9a63b86e0)

<p>

# ✅Dependency Injection Lifecycle Scopes
| **Scope**      | **Instance Creation**                          | **Sharing**                     | **Use Case**                     |
|----------------|-------------------------------------------------|---------------------------------|----------------------------------|
| **Singleton**  | Once for the entire application lifecycle       | Same instance for all consumers | Logging, Cache, Configurations   |
| **Transient**  | A new instance every time it's requested        | Different instance for each call | Stateless services, Helpers      |
| **Scoped**     | Once per request (e.g., per HTTP request)       | Same instance within the request | User-related services (Web apps) |

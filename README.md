# Dotnet 7 API with Docker and NGINX

This is a simple API that returns a JSON response with the weather forecast. It is running in a Docker container with NGINX as a reverse proxy

## Build and run

```bash
docker compose build
```

```bash
docker compose up
```

## Visit the API

### /weatherforecast

[https://localhost:8084/weatherforecast](https://localhost:8084/weatherforecast)

### /health/live

[https://localhost:8084/health/live](https://localhost:8084/health/live)

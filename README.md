# Изменения 
Проект контейнеризирован при помощи Docker. База данных размещена на сервере, теперь не нужно создавать и запускать её. Исправлена архитектура. DI теперь выполняет функции DI, бизнес логика перенесена в сервисы, в контроллерах происходит маппинг и вызов сервисов.


# Event Managment API

Тестовое задание.

## Prerequisites

Docker 

## Run Locally

Clone the project

```bash
  git clone https://github.com/igor-goss/EventManagmentAPI.git
```

Go to project folder

```bash
  cd eventsApi
```

Run docker-compose

```bash
  docker-compose up --build
```

## API Reference

#### Get all events

```http
  GET /api/Event
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `none` | `string` | Returns a list of all items |

#### Get events

```http
  GET /api/Event/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | Id of item to fetch |

#### Create event

```http
  POST /api/Event/
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `Event`      | `Event` | **Requires autorization** Adding a new event |

#### Edit event

```http
  PUT /api/Event/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `Event`      | `Event` | **Requires autorization** Editing an existing event |

#### Delete event

```http
  DELETE /api/Event/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `int` | **Requires autorization** Deleting an existing event |




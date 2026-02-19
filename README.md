# Enterprise Document Intelligence Assistant (RAG)

## 🚀 Overview
Production-style Retrieval-Augmented Generation system built with:
- ASP.NET Core 8
- Semantic Kernel
- Azure OpenAI
- Azure AI Search
- SQL Server

---

## 🏗 Architecture
![Architecture](docs/architecture.png)

---

## 🔄 RAG Flow
1. Document Upload
2. Chunking
3. Embedding Generation
4. Vector Indexing
5. Context Retrieval
6. LLM Response Generation
7. Token Logging

---

## 🔐 Security
- Secure configuration via environment variables
- Role-based access
- Token usage monitoring

---

## 📊 Cost Monitoring
Tracks:
- Prompt tokens
- Completion tokens
- Estimated cost

---

## 🐳 Run with Docker

docker-compose up --build

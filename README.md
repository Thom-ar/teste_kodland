# Projeto de Jogo em Unity

Este projeto é uma pequena aplicação de jogo em Unity com foco em movimentação, mira, tiro e objetivos. O jogador controla um personagem que pode andar pelo cenário, atirar em inimigos, coletar itens de cura e vencer ou perder conforme o estado do jogo.

## Objetivo do jogo

O objetivo principal é explorar o ambiente, eliminar inimigos, coletar itens de recuperação de vida e alcançar o ponto de vitória sem perder todas as vidas.

## Funcionalidades

- Movimento do personagem com CharacterController
- Controle de câmera e visão com mouse
- Sistema de disparo com projéteis
- Detecção de colisão com inimigos e itens
- Sistema de vida do jogador
- Tela de vitória e game over
- Interação com objetos de cura e objetivo final

## Scripts principais

- `PlayerController.cs`: controla o movimento, tiro, vida, vitória e derrota
- `PlayerLook.cs`: gerencia a rotação da câmera e do personagem pela entrada do mouse
- `Bullet.cs`: responsável pelo comportamento dos projéteis disparados pelo jogador

## Controles

- WASD ou setas: movimentação
- Mouse: mira e rotação da câmera
- Clique esquerdo: atirar
- Clique direito: ação de ataque ou eliminação próxima

## Requisitos

- Unity instalado
- Projeto aberto no Editor do Unity
- Scene configurada com objetos de jogo, inimigos, itens e referências dos scripts

## Estado do projeto

É um projeto de prática e protótipo de jogo, com lógica básica de combate e progressão. Pode servir como base para evoluções como:

- sistema de inimigos mais avançado
- painel de HUD com vida e pontuação
- sons e efeitos visuais
- menu inicial e pausa
- level design mais elaborado

## Observação

Este repositório contém assets e scripts de um jogo simples criado para estudo e desenvolvimento inicial em Unity.

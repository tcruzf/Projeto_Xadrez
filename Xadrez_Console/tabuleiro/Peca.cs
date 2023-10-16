﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace tabuleiro {
     class Peca {
        public Posicao posicao { get; set; }
        public Cor cor {  get; protected set; }
        public int qteMovimento { get; protected set; }
        public Tabuleiro tab {  get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor) { 
            this.posicao = posicao;
            this.tab = tabuleiro;
            this.cor = cor;
           this.qteMovimento = 0;


        }

    }
}

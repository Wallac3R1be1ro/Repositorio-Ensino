package com.example.exercicio5;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.Random;

public class MainActivity extends AppCompatActivity {

    private TextView tmtza, tmtzb, tRes;
    private Random rand = new Random();

    // criando as matrizes para efetuar as contas
    private int[][] mtza = new int[4][5];
    private int[][] mtzb = new int[5][2];
    private int[][] mtzc = new int[4][2];


    @SuppressLint("MissingInflatedId")
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);

        // buscando no layout os objetos
        tmtza = findViewById(R.id.tMtzA);
        tmtzb = findViewById(R.id.tMtzB);
        tRes  = findViewById(R.id.tRes);

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }

    // metodo do botao calcular
    public void bCalc(View view) {
        int i, j;
        String aux;
        int soma1, soma2;

        // gerando nros aleatorios para as matrizes
        // e mostrando no layout as matrizes geradas

        // 1º matriz 4x5
        aux = "Matriz 4x5\n\n";
        for (i = 0; i < 4; i++) {
            for (j = 0; j < 5; j++) {
                mtza[i][j] = rand.nextInt(50);
                aux += mtza[i][j] + " ";
            }
            aux += "\n";
        }
        tmtza.setText( aux );


        // 2º matriz 5x2
        aux = "Matriz 5x2\n\n";
        for (i = 0; i < 5; i++) {
            for (j = 0; j < 2; j++) {
                mtzb[i][j] = rand.nextInt(50);
                aux += mtzb[i][j] + " ";
            }
            aux += "\n";
        }
        tmtzb.setText( aux );


        // multiplicando as matrizes e gerando uma matriz 4x2
        aux = "Resultado da multiplicação\nMatrizes 4x5 e 5x2\n\n";
        for (i = 0; i < 4; i++) {
            soma1 = 0; soma2 = 0;
            for (j = 0; j < 5; j++) {
                soma1 += mtza[i][j] * mtzb[j][0];
                soma2 += mtza[i][j] * mtzb[j][1];
            }
            mtzc[i][0] = soma1;
            mtzc[i][1] = soma2;
            aux += mtzc[i][0] + " " + mtzc[i][1] + " \n";
        }
        tRes.setText( aux );

    }


    // metodo do botao finalizar app
    public void bSair(View view) {
        // finalizando o app, ou seja, fechando a aplicação
        finish();
    }
}
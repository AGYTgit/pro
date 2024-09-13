class Program_2 {
    static void Main() {

        int[] input_param = {0,0,0};
        char[,] output_param;
        int num = 0;

        for (int i = 0; i < 3; i++) {
            var input = Console.ReadLine();
            if (input != null) {
                input_param[i] = int.Parse(input);
            }
        }

        if (input_param[0] == 3) {
            output_param = new char[input_param[1], input_param[1]];
            for (int i = 0; i < input_param[1]; i++) {
                for (int j = 0; j < input_param[1]; j++) {
                    output_param[i, j] = ' ';
                }
            }
        } else {
            output_param = new char[input_param[2], input_param[1]];
            for (int i = 0; i < input_param[2]; i++) {
                for (int j = 0; j < input_param[1]; j++) {
                    output_param[i, j] = ' ';
                }
            }
        }

        switch (input_param[0]) {
            case 0:
                for (int i = 0; i < input_param[2]; i++) {
                    for (int j = 0; j < input_param[1]; j++) {
                        output_param[i, j] = 'X';
                    }
                }
                break;
            case 1:
                for (int j = 0; j < input_param[1]; j++) {
                    output_param[0, j] = 'X';
                    output_param[input_param[2] - 1, j] = 'X';
                }
                for (int i = 1; i < input_param[2] - 1; i++) {
                    output_param[i, 0] = 'X';
                    output_param[i, input_param[1] - 1] = 'X';
                }
                break;
            case 2:
                for (int j = 0; j < input_param[1]; j++) {
                    output_param[0, j] = 'X';
                    output_param[input_param[2] - 1, j] = 'X';
                }
                for (int i = 1; i < input_param[2] - 1; i++) {
                    output_param[i, 0] = 'X';
                    output_param[i, input_param[1] - 1] = 'X';
                }

                for (int i = 1; i < input_param[2] - 1; i++) {
                    for (int j = 1; j < input_param[1] - 1; j++) {
                        output_param[i, j] = num.ToString()[0];
                        num = (num + 1) % 10;
                    }
                }
                break;
            case 3:
                for (int i = 0; i < input_param[1]; i++) {
                    output_param[i, i] = 'X';
                }
                break;
            case 6:
                for (int j = 0; j < input_param[1]; j++) {
                    output_param[0, j] = 'X';
                }
                for (int i = 1; i < input_param[2]; i++) {
                    output_param[i, (input_param[1] - 1) / 2] = 'X';
                }
                break;
            case 9:
                for (int j = 0; j < input_param[1]; j++) {
                    output_param[0, j] = 'X';
                    output_param[input_param[2] - 1, j] = 'X';
                }
                for (int i = 1; i < input_param[2] - 1; i++) {
                    output_param[i, 0] = 'X';
                    output_param[i, input_param[1] - 1] = 'X';
                }

                for (int i = 1; i < input_param[1] - 1; i++) {
                    for (int j = 1; j < input_param[2] - 1; j++) {
                        output_param[j, i] = num.ToString()[0];
                        num = (num + 1) % 10;
                    }
                }
                break;
        }

        

        if (input_param[0] == 3) {
            for (int i = 0; i < input_param[1]; i++) {
                for (int j = 0; j < input_param[1]; j++) {
                    Console.Write(output_param[i, j]);
                }
                Console.WriteLine();
            }
        } else {
            for (int i = 0; i < input_param[2]; i++) {
                for (int j = 0; j < input_param[1]; j++) {
                    Console.Write(output_param[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
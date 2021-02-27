import wpf

from System.Windows import Application, Window

class MyWindow(Window):
    def __init__(self):
        wpf.LoadComponent(self, 'Perceptron_py.xaml')
    

if __name__ == '__main__':
    Application().Run(MyWindow())

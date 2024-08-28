class Counter:
    def __init__(self, name):
        self.count = 0
        self.name = name

    def increment(self):
        self.count += 1

    def reset(self):
        self.count = 0

    @property
    def tick(self):
        return self.count

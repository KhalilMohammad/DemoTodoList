import { TodoListTemplatePage } from './app.po';

describe('TodoList App', function() {
  let page: TodoListTemplatePage;

  beforeEach(() => {
    page = new TodoListTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
